
using OpenAI_API;

// See https://aka.ms/new-console-template for more information Console.WriteLine("Hello, World!");

var api = new OpenAIAPI("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");
var request = new OpenAI_API.Images.ImageGenerationRequest 
{
Prompt = "A cute kitten in a basket"
};

var response = api. ImageGenerations.CreateImageAsync(request); 
Console.WriteLine("Image URL: {0}", response.Data[0].Url);

// run using dotnet run
