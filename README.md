# IEnumerable-visualizer-is-buggy
Sample project to show IEnumerable visualizer is buggy as it shows .key and .key, it’s missing .value column.

## How to reproduce
After loading this into Visual Studio 2022, run the project [WebApplication1](WebApplication1/WebApplication1.csproj), it'll automatically break the debugger into [Program.cs#L7](https://github.com/lgp1985/IEnumerable-visualizer-is-buggy/blob/545754054377a9371ef25ee807e23482dce9e73f/WebApplication1/Program.cs#L7), so you can inspect `inspectMe` and click on _🔍 View_.

The new window will look like this ![Sample of the issue](/docs/sampleVis.png)
