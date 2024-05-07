<Query Kind="Program" />

using System.Linq;
using System.Collections.Generic;

void Main()
{
	var articles = new List<Article> {
		new (){Name = "A", ProcessingType = ProcessingType.NoProcessing},
		new (){Name = "G", ProcessingType = ProcessingType.ASimpleProcessing},
		new (){Name = "X", ProcessingType = ProcessingType.NoProcessing},
		new (){Name = "E", ProcessingType = ProcessingType.ASimpleProcessing},
		new (){Name = "B", ProcessingType = ProcessingType.NoProcessing},
	};
	
	articles.OrderBy(x => x.ProcessingType).ThenBy(x => x.Name).Dump();

}

enum ProcessingType {
	NoProcessing = 0,
	ASimpleProcessing = 1,
	FastlaneProcessing = 2
}

class Article {
	public string Name {get; set;}
	public ProcessingType ProcessingType {get;set;}
}
