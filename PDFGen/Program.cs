using MongoDB.Bson;

//iText
using iText;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

//System
using System;
using System.Security.Authentication;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Text.Json;

//using 'overarching namespace e.g., La Casa'.QuickType;
//using System.Text.Json;

namespace PDFGen
{
    class Program
    {
        // location for PDF to be stored
        static string PDF_LOCATION = "./out.pdf";
        static int MAX_NUM_COLS = 3;


        // returns a new paragraph given the string and font size
        static Paragraph newPar(string text, int font)
        {
            Paragraph p = new Paragraph(text)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(font);

            return p;
        }

        // returns a new cell, given the string to add as text and font size
        static Cell newCell(string text, int font)
        {
            Cell c = new Cell()
                .Add(newPar(text, font));

            return c;
        }


        // adds 2 new entries to the table at a given indentation level,
        // then pads the row to consume it
        static void newTableEntryPair(Table table, string text1, string text2,
                                        int font, int indent)
        {

            if (indent + 2 > MAX_NUM_COLS) {
                Console.WriteLine("ERROR: too much indentation!");
                return;
            }

            // add blank cells in table for indentation
            for (int i = 0; i < indent; ++i) {
                table.AddCell(newCell(
                    "", 10
                ));
            }

            // add cell 1
            table.AddCell(newCell(
                text1, font
            ));

            // add cell 2
            table.AddCell(newCell(
                text2, font
            ));

            // add two to indent since we just added two cells
            indent = indent + 2;

            // pad end of row until it's full
            if (indent < MAX_NUM_COLS) {
                for (int i = indent; i < MAX_NUM_COLS; ++i) {
                    table.AddCell(newCell(
                        "", 10
                    ));
                }
            }
        }


        // adds 1 new entry to the table at a given indentation level,
        // then pads the row to consume it
        static void newTableEntry(Table table, string text, int font, int indent)
        {

            // add blank cells in table for indentation
            for (int i = 0; i < indent; ++i) {
                table.AddCell(newCell(
                    "", 10
                ));
            }

            // add our cell
            table.AddCell(newCell(
                text, font
            ));

            // add one to indent since we just added one cell
            indent++;

            // pad end of row until it's full
            if (indent < MAX_NUM_COLS) {
                for (int i = indent; i < MAX_NUM_COLS; ++i) {
                    table.AddCell(newCell(
                        "", 10
                    ));
                }
            }
        }


        // change a string '0' or '1', 'False' or 'True, to ' ' or 'x'
        static string boolToString(string ans)
        {
            string readable;
            if (ans.Equals("0") || ans.Equals("False")) {
                readable = " ";
            }
            else if (ans.Equals("1") || ans.Equals("True")) {
                readable = "X";
            }
            else {
                readable = "unknown, FIX ME";
            }

            return readable;
        }


        static Table cvtAssessmentToTable(Assessment a)
        {
            // init table to be returned
            Table table = new Table(new float[MAX_NUM_COLS]);
            table.SetWidth(
                //width of table is available width of page divided by cols
                // to evenly space cells
                UnitValue.CreatePercentValue(100/MAX_NUM_COLS)
            );

            JsonDocument assessmentJson = JsonDocument.Parse(JsonSerializer.Serialize(a));

//            string[] sections = new string[];
 //           JsonDocument assessmentJson = JsonDocument
//                                            .Parse(JsonSerializer.Serialize(assessment));
            // parse this json document
            // get string, get property, check type
            // group element.enumerate object
            //assessmentJson.RootElement;

            // recurisve?
            // for every table entry, loop through sections[]
        /*
            for () {
                newTableEntry(table, firstforloopkey, 10, 0);
                // if value of key isn't a string then enter another for loop
                // 2nd layer for
                for () {
                    // if value of key isn't a string then enter another for loop
                    // for(){}
                    newTableEntryPair(table, "Self", boolToString("0"), 10, 1);
                }
                
            }
            */



            

            return table;
        }

        static void Main(string[] args)
        {
            // ---INITIALIZATION ---
            // create directory/path if it didn't exist
            FileInfo file = new FileInfo(PDF_LOCATION);
            file.Directory.Create();

            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(PDF_LOCATION));
            Document doc = new Document(pdfDoc);

            // ---TABLE/DOCUMENT FORMATTING---
            // --SERVICE ASSESSMENT--
            // title
            doc.Add(newPar("SERVICE ASSESSMENT", 20));
            // table holds all form information

            Assessment a = new Assessment();
            a.ReferredBy.Self = "yes";
            cvtAssessmentToTable(a);






            /*
            newTableEntry(table, "Referred By", 10, 0);
            // put all class names in an array /(data member names)
            // iterate each key
                // if key is not a string
                    // increase indentation level


            //--BEGIN REFERRED BY--
            // TODO figure out how to align left.
            newTableEntry(table, "Referred By", 10, 0);
            // question
            newTableEntryPair(table, "Self", boolToString("0"), 10, 1);
            // answer
            newTableEntryPair(table, "Other", boolToString("1"), 10, 1);

            */
            doc.Add(table);
            // ---SAVE AND CLEANUP---
            doc.Close();
        }
    }
}
