﻿Imports d3svg

Module Program

    Sub Main()
        Dim parser As D3Parser = New ForceDirectedGraph
        Dim svg As SVG = parser.HtmlParser("F:\GCModeller.Workbench\d3js\d3svg\data\example_svg_html.htm")
        Call svg.Build.SaveTo("./test.svg")
    End Sub
End Module
