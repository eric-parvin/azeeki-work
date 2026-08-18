const fs = require("fs");
const path = require("path");
const {
  AlignmentType,
  Document,
  HeadingLevel,
  Packer,
  Paragraph,
  TextRun,
} = require("docx");

const outputPath = process.argv[2];

if (!outputPath) {
  throw new Error("Usage: node generate_forms_import.js <output.docx>");
}

const children = [];
let questionNumber = 0;

function section(title) {
  children.push(
    new Paragraph({
      heading: HeadingLevel.HEADING_2,
      children: [new TextRun(title)],
    }),
  );
}

function subsection(title) {
  children.push(
    new Paragraph({
      heading: HeadingLevel.HEADING_3,
      children: [new TextRun(title)],
    }),
  );
}

function reference(text) {
  children.push(
    new Paragraph({
      style: "ReferenceText",
      children: [new TextRun({ text, italics: true })],
    }),
  );
}

function question(text, options = []) {
  questionNumber += 1;
  children.push(
    new Paragraph({
      style: "Question",
      keepNext: options.length > 0,
      children: [new TextRun(`${questionNumber}. ${text}`)],
    }),
  );

  options.forEach((option, index) => {
    children.push(
      new Paragraph({
        style: "AnswerChoice",
        keepNext: index < options.length - 1,
        children: [
          new TextRun(`${String.fromCharCode(65 + index)}. ${option}`),
        ],
      }),
    );
  });

  children.push(new Paragraph({ style: "QuestionSpacer" }));
}

function addPortfolioQuestions(portfolio) {
  subsection(portfolio);
  question(`Enter the number of loans in the ${portfolio} portfolio.`);
  question(`Enter the number of originations per month for the ${portfolio} portfolio.`);
  question(`Enter the escrow percentage for the ${portfolio} portfolio.`);
  question(`Enter the flood properties value for the ${portfolio} portfolio.`);
  question(`Does the ${portfolio} portfolio have blanket potential?`, ["Yes", "No"]);
}

function addCollateralQuestions(collateral) {
  subsection(collateral);
  question(`Enter the number of loans for ${collateral}.`);
  question(`Is force placement used for ${collateral}?`, ["Yes", "No"]);
}

function addLenderPlacedQuestions(coverage, portfolio) {
  subsection(`${coverage} - ${portfolio}`);
  question(`Enter the current carrier for ${coverage.toLowerCase()} coverage on the ${portfolio.toLowerCase()} portfolio.`);
  question(`Enter the number of active ${coverage.toLowerCase()} policies for the ${portfolio.toLowerCase()} portfolio.`);
  question(`Enter the earned ${coverage.toLowerCase()} premium for the last 12 months for the ${portfolio.toLowerCase()} portfolio.`);
  question(`Enter the earned ${coverage.toLowerCase()} premium for the previous 12 months for the ${portfolio.toLowerCase()} portfolio.`);
}

children.push(
  new Paragraph({
    heading: HeadingLevel.TITLE,
    alignment: AlignmentType.CENTER,
    children: [new TextRun("Real Estate Tracking Prospect Sales Brief")],
  }),
);

section("Submission and Prospect");
question("Enter the submission date.");
question("Enter the company name.");
question("Enter the location, including city and state.");
question("Enter the asset size.");

section("Portfolio Characteristics");
["Residential", "Equities", "Commercial"].forEach(addPortfolioQuestions);

section("Other Collateral");
["Automobiles", "BPP/Equipment", "C&I"].forEach(addCollateralQuestions);

section("Lender Placed - Hazard");
["Residential", "Commercial"].forEach((portfolio) =>
  addLenderPlacedQuestions("Hazard", portfolio),
);

section("Lender Placed - Flood");
["Residential", "Commercial"].forEach((portfolio) =>
  addLenderPlacedQuestions("Flood", portfolio),
);

section("Background Questions");
question("Is this prospect a current L&M client?", ["Yes", "No"]);
reference("If yes, enter the annual premium for each applicable product below.");
question("Enter the annual premium for Order Up.");
question("Enter the annual premium for Blanket Hazard.");
question("Enter the annual premium for LSI/VSI.");
question("Enter any additional notes.");
question("Enter the requested proposal date.");
reference("Please allow five business days. If needed more urgently, contact the Product Manager.");
question("Will standard pricing be used?", ["Yes", "No"]);

section("Standard Pricing Matrix - Reference");
reference("Less than 5,000 loans: Residential rate 90; Commercial rate (1-2 collateral) 90; Commercial rate (3 or more) 180; Monthly minimum $5,000; Annual minimum N/A.");
reference("More than 5,000 loans: Residential rate 90; Commercial rate (1-2 collateral) 90; Commercial rate (3 or more) 180; Monthly minimum $5,000; Annual minimum 12% or fixed dollar amount.");
reference("More than 20,000 loans: Contact the Product Manager.");

section("Suggested Increase to Life Rates");
reference("For fewer than 5,000 loans, the monthly minimum is $5,000 and the annual minimum is N/A.");
question("Enter the suggested residential rate for fewer than 5,000 loans.");
question("Enter the suggested commercial rate for one to two collateral types for fewer than 5,000 loans.");
question("Enter the suggested commercial rate for three or more collateral types for fewer than 5,000 loans.");

section("Suggested Pricing Deviation");
reference("To qualify for a pricing deviation, the prospect must have other business with L&M that can be used to subsidize tracking program revenue or sufficient earned premium information in the Lender Placed sections. A pricing deviation requires discussion with the Product Manager to determine final proposal pricing.");
question("Enter the standard pricing tier or category for the suggested pricing deviation.");
question("Enter the residential rate for the suggested pricing deviation.");
question("Enter the commercial rate for one to two collateral types for the suggested pricing deviation.");
question("Enter the commercial rate for three or more collateral types for the suggested pricing deviation.");
question("Enter the monthly per-loan amount for the suggested pricing deviation.");
question("Enter the monthly minimum for the suggested pricing deviation.");
question("Enter the annual minimum for the suggested pricing deviation.");
question("Enter additional notes about the prospect related to the requested pricing deviation.");

section("Acknowledgment");
reference("I understand that the policy will be issued in reliance upon the authority contained therein. I state that all information is accurate to the best of my ability and belief.");
question("Enter your full name as your signature to acknowledge the statement above.");

const document = new Document({
  creator: "GitHub Copilot",
  title: "Real Estate Tracking Prospect Sales Brief - Forms Import",
  description: "Vertically structured source document for Microsoft Forms Quick Import.",
  styles: {
    default: {
      document: {
        run: { font: "Arial", size: 22, color: "20242E" },
        paragraph: { spacing: { after: 100 } },
      },
    },
    paragraphStyles: [
      {
        id: "Title",
        name: "Title",
        basedOn: "Normal",
        next: "Normal",
        quickFormat: true,
        run: { font: "Arial", size: 36, bold: true, color: "006B3C" },
        paragraph: { spacing: { after: 360 }, outlineLevel: 0 },
      },
      {
        id: "Heading2",
        name: "Heading 2",
        basedOn: "Normal",
        next: "Normal",
        quickFormat: true,
        run: { font: "Arial", size: 28, bold: true, color: "20242E" },
        paragraph: { spacing: { before: 300, after: 160 }, outlineLevel: 1 },
      },
      {
        id: "Heading3",
        name: "Heading 3",
        basedOn: "Normal",
        next: "Normal",
        quickFormat: true,
        run: { font: "Arial", size: 24, bold: true, color: "006B3C" },
        paragraph: { spacing: { before: 200, after: 120 }, outlineLevel: 2 },
      },
      {
        id: "Question",
        name: "Question",
        basedOn: "Normal",
        next: "Normal",
        run: { font: "Arial", size: 22 },
        paragraph: { spacing: { before: 80, after: 60 }, keepNext: true },
      },
      {
        id: "AnswerChoice",
        name: "Answer Choice",
        basedOn: "Normal",
        next: "Normal",
        run: { font: "Arial", size: 22 },
        paragraph: { indent: { left: 540 }, spacing: { after: 40 } },
      },
      {
        id: "ReferenceText",
        name: "Reference Text",
        basedOn: "Normal",
        next: "Normal",
        run: { font: "Arial", size: 20, italics: true, color: "4B5563" },
        paragraph: { spacing: { after: 120 } },
      },
      {
        id: "QuestionSpacer",
        name: "Question Spacer",
        basedOn: "Normal",
        next: "Normal",
        run: { font: "Arial", size: 8 },
        paragraph: { spacing: { after: 80 } },
      },
    ],
  },
  sections: [
    {
      properties: {
        page: {
          size: { width: 12240, height: 15840 },
          margin: { top: 900, right: 1080, bottom: 900, left: 1080 },
        },
      },
      children,
    },
  ],
});

fs.mkdirSync(path.dirname(outputPath), { recursive: true });
Packer.toBuffer(document).then((buffer) => fs.writeFileSync(outputPath, buffer));