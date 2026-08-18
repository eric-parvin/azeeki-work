const fs = require("fs");
const path = require("path");
const {
  AlignmentType,
  Document,
  Footer,
  HeadingLevel,
  LevelFormat,
  Packer,
  PageNumber,
  Paragraph,
  TextRun,
} = require("docx");

const outputPath = path.join(
  __dirname,
  "..",
  "RE Tracking Prospect Sales Brief - Forms Import.docx",
);

const children = [];

function addSection(title, description) {
  children.push(
    new Paragraph({
      heading: HeadingLevel.HEADING_2,
      children: [new TextRun(title)],
    }),
  );

  if (description) {
    children.push(
      new Paragraph({
        style: "FormDescription",
        children: [new TextRun(description)],
      }),
    );
  }
}

function addQuestion(text, options = []) {
  children.push(
    new Paragraph({
      numbering: { reference: "questions", level: 0 },
      keepNext: options.length > 0,
      children: [new TextRun({ text, bold: true })],
    }),
  );

  for (const option of options) {
    children.push(
      new Paragraph({
        numbering: { reference: "choices", level: 0 },
        children: [new TextRun(option)],
      }),
    );
  }
}

function addPortfolioQuestions(label) {
  addQuestion(`${label}: number of loans`);
  addQuestion(`${label}: number of originations per month`);
  addQuestion(`${label}: escrow percentage`);
  addQuestion(`${label}: number of flood properties`);
  addQuestion(`${label}: blanket potential`, ["Yes", "No"]);
}

function addCollateralQuestions(label) {
  addQuestion(`${label}: number of loans`);
  addQuestion(`${label}: force placement`, ["Yes", "No"]);
}

function addLenderPlacedQuestions(section, label) {
  addQuestion(`${section} - ${label}: current carrier`);
  addQuestion(`${section} - ${label}: number of active policies`);
  addQuestion(`${section} - ${label}: earned premium, last 12 months`);
  addQuestion(`${section} - ${label}: earned premium, previous 12 months`);
}

children.push(
  new Paragraph({
    heading: HeadingLevel.TITLE,
    alignment: AlignmentType.CENTER,
    children: [
      new TextRun("Real Estate Tracking Prospect Sales Brief"),
    ],
  }),
  new Paragraph({
    style: "FormDescription",
    alignment: AlignmentType.CENTER,
    children: [
      new TextRun(
        "Use this form to capture prospect portfolio, collateral, lender-placed coverage, and requested pricing information.",
      ),
    ],
  }),
);

addSection("Submission and prospect");
addQuestion("Submission date");
addQuestion("Company");
addQuestion("Location (city, state)");
addQuestion("Asset size");

addSection("Portfolio characteristics");
addPortfolioQuestions("Residential");
addPortfolioQuestions("Equities");
addPortfolioQuestions("Commercial");

addSection("Other collateral");
addCollateralQuestions("Automobiles");
addCollateralQuestions("BPP/Equipment");
addCollateralQuestions("C&I");

addSection("Lender placed - hazard");
addLenderPlacedQuestions("Hazard", "Residential");
addLenderPlacedQuestions("Hazard", "Commercial");

addSection("Lender placed - flood");
addLenderPlacedQuestions("Flood", "Residential");
addLenderPlacedQuestions("Flood", "Commercial");

addSection(
  "Background questions",
  "If the prospect is not a current L&M client, skip the product premium questions.",
);
addQuestion("Is this a current L&M client?", ["Yes", "No"]);
addQuestion("Current L&M client - Order Up annual premium");
addQuestion("Current L&M client - Blanket Hazard annual premium");
addQuestion("Current L&M client - LSI/VSI annual premium");
addQuestion("Additional notes");
addQuestion("Requested proposal date");

addSection(
  "Pricing",
  "Standard pricing reference: fewer than 5,000 loans - residential rate 90; commercial rate (1-2 collateral) 90; commercial rate (3 or more) 180; monthly minimum $5,000; annual minimum not applicable. More than 5,000 loans - rates and monthly minimum are the same; annual minimum is 12% or a fixed amount. More than 20,000 loans - contact the Product Manager.",
);
addQuestion("Is standard pricing requested?", ["Yes", "No"]);
addQuestion("If no, select the nonstandard pricing request type", [
  "Suggested increase to LIFE rates",
  "Suggested pricing deviation",
  "Other",
]);

addSection(
  "Suggested increase to LIFE rates",
  "Complete this section only when this nonstandard pricing request type is selected.",
);
addQuestion("Suggested LIFE residential rate");
addQuestion("Suggested LIFE commercial rate (1-2 collateral)");
addQuestion("Suggested LIFE commercial rate (3 or more)");
addQuestion("Suggested LIFE monthly minimum");
addQuestion("Suggested LIFE annual minimum");

addSection(
  "Suggested pricing deviation",
  "A deviation requires other L&M business that can subsidize tracking program revenue or sufficient earned premium information in the lender-placed sections. Discuss final proposal pricing with the Product Manager.",
);
addQuestion("Suggested pricing deviation - standard pricing basis or tier");
addQuestion("Suggested pricing deviation - residential rate");
addQuestion("Suggested pricing deviation - commercial rate (1-2 collateral)");
addQuestion("Suggested pricing deviation - commercial rate (3 or more)");
addQuestion("Suggested pricing deviation - monthly per loan");
addQuestion("Suggested pricing deviation - monthly minimum");
addQuestion("Suggested pricing deviation - annual minimum");
addQuestion("Additional notes about the requested pricing deviation");

addSection("Acknowledgment");
addQuestion(
  "Acknowledgment",
  [
    "I understand that the policy will be issued in reliance upon the authority contained therein. I state that all information is accurate to the best of my ability and belief.",
  ],
);
addQuestion("Typed signature (full name)");

const doc = new Document({
  styles: {
    default: {
      document: {
        run: { font: "Arial", size: 22, color: "20252D" },
        paragraph: { spacing: { after: 120 } },
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
        paragraph: { spacing: { after: 180 }, outlineLevel: 0 },
      },
      {
        id: "Heading2",
        name: "Heading 2",
        basedOn: "Normal",
        next: "Normal",
        quickFormat: true,
        run: { font: "Arial", size: 26, bold: true, color: "20252D" },
        paragraph: {
          spacing: { before: 260, after: 100 },
          outlineLevel: 1,
          border: {
            bottom: { style: "single", size: 6, color: "006B3C", space: 4 },
          },
        },
      },
      {
        id: "FormDescription",
        name: "Form Description",
        basedOn: "Normal",
        next: "Normal",
        run: { font: "Arial", size: 20, italics: true, color: "4A5561" },
        paragraph: { spacing: { after: 160 } },
      },
    ],
  },
  numbering: {
    config: [
      {
        reference: "questions",
        levels: [
          {
            level: 0,
            format: LevelFormat.DECIMAL,
            text: "%1.",
            alignment: AlignmentType.LEFT,
            style: { paragraph: { indent: { left: 480, hanging: 360 } } },
          },
        ],
      },
      {
        reference: "choices",
        levels: [
          {
            level: 0,
            format: LevelFormat.BULLET,
            text: "-",
            alignment: AlignmentType.LEFT,
            style: { paragraph: { indent: { left: 960, hanging: 360 } } },
          },
        ],
      },
    ],
  },
  sections: [
    {
      properties: {
        page: {
          size: { width: 12240, height: 15840 },
          margin: { top: 1080, right: 1080, bottom: 1080, left: 1080 },
        },
      },
      footers: {
        default: new Footer({
          children: [
            new Paragraph({
              alignment: AlignmentType.RIGHT,
              children: [
                new TextRun("Forms import questionnaire | Page "),
                new TextRun({ children: [PageNumber.CURRENT] }),
              ],
            }),
          ],
        }),
      },
      children,
    },
  ],
});

Packer.toBuffer(doc)
  .then((buffer) => {
    fs.writeFileSync(outputPath, buffer);
    console.log(`Created ${outputPath}`);
  })
  .catch((error) => {
    console.error(error);
    process.exitCode = 1;
  });