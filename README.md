# NullObjExperiment

A simple example of how you might use a Roslyn Source Generator to automatically make "null object" instances of existing interfaces. It's basic proof-of-concept code, not finished or good practice. Just something I hacked together to see if this idea might work.

There are two projects here:

* **NullObjectExperiment**<br/>
  This is the test project, and it references the source generator to make use of its ability to generate code. It defines two example interfaces (`IConnection` and `INetwork`), which are tagged with an attribute to indicate they should be used for generation. And there's an extemely basic main program file which just checks the generation happened. This is using .Net 8 - but that's probably not important. You can see the generated code under _Dependencies / Analyzers / NullObjGenerator_ in the project tree.

* **NullObjGenerator**<br/>
  This is the Source Generator project. It's a .Net Standard 2 project - and it has to be for the source generator to be usable with Visual Studio. This only contains one class, which is the (rather messy) generator.

This code goes with <a href="#">a blog post I wrote on this topic</a>.