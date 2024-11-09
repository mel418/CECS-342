// Program.cs
//
// CECS 342 Assignment 3
// File Type Report
// Solution Template

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace FileTypeReport {
  internal static class Program {
    // 1. Enumerate all files in a folder recursively
    private static IEnumerable<string> EnumerateFilesRecursively(string path) {
      // TODO: Fill in your code here.

      // Use Directory.EnumerateFiles to get all files recursively
      return Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);
    }

    // Human readable byte size
    private static string FormatByteSize(long byteSize) {
      // TODO: Fill in your code here.

      // Define the units of file size
      string[] units = { "B", "kB", "MB", "GB", "TB", "PB", "EB", "ZB" };
      double size = byteSize;
      int unitIndex = 0;

      // Convert to appropriate size units
      while (size >= 1000 && unitIndex < units.Length - 1) {
        size /= 1000;
        unitIndex++;
      }

      // Return the formatted size (rounded to 2 decimal places)
      return $"{size:F2}{units[unitIndex]}";
    }

    // Create an HTML report file
    private static XDocument CreateReport(IEnumerable<string> files) {
      // 2. Process data
      var query =
        from file in files
        // TODO: Fill in your code here.

        let fileInfo = new FileInfo(file)  // Get file info for size calculation
        group fileInfo by fileInfo.Extension.ToLower() into fileGroup  // Group by file extension
        select new {
          Type = fileGroup.Key, // file extension
          Count = fileGroup.Count(),
          TotalSize = fileGroup.Sum(f => f.Length)  // Total size of files in this group
        };

      // 3. Functionally construct XML
      var alignment = new XAttribute("align", "right");
      var style = "table, th, td { border: 1px solid black; }";

      // TODO: Fill in your code here.
      var tableRows = query.Select(fileGroup =>
        new XElement("tr",
            new XElement("td", fileGroup.Type),  // File type (extension)
            new XElement("td", fileGroup.Count),  // File count
            new XElement("td", FormatByteSize(fileGroup.TotalSize))  // Formatted size
        ));
        
      var table = new XElement("table",
        new XElement("thead",
          new XElement("tr",
            new XElement("th", "Type"),
            new XElement("th", "Count"),
            new XElement("th", "Total Size"))),
        new XElement("tbody", tableRows));

      return new XDocument(
        new XDocumentType("html", null, null, null),
          new XElement("html",
            new XElement("head",
              new XElement("title", "File Report"),
              new XElement("style", style)),
            new XElement("body", table)));
    }

    // Console application with two arguments
    public static void Main(string[] args) {
      try {
        string inputFolder = args[0];
        string reportFile  = args[1];
        CreateReport(EnumerateFilesRecursively(inputFolder)).Save(reportFile);
      } catch {
        Console.WriteLine("Usage: FileTypeReport <folder> <report file>");
      }
    }
  }
}