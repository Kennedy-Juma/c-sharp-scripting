// This code demonstrates how to reference a NuGet package in a C# script.
#:package Humanizer@2.14.1

using Humanizer;

string mySentence = "c# is a powerful aNd versAtile proGramming LanguaGe.";

string humanizedSentence = mySentence.Transform(To.LowerCase, To.TitleCase);

Console.WriteLine(humanizedSentence);
