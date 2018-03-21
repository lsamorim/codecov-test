# test
How did I do it?   
Build passing: https://docs.microsoft.com/en-us/vsts/build-release/actions/ci-build-github   

Codecov: https://github.com/codecov/example-csharp
```
OpenCover.Console.exe "-target:C:\Program Files\dotnet\dotnet.exe"  -targetargs:test -register:user -filter:"+[*]* -[xunit*]*" -output:coverage.xml -oldstyle
codecov -f "coverage.xml" -t <your upload token>
```

[![Build Status](https://lsamorim-test.visualstudio.com/_apis/public/build/definitions/fb84aa15-dca6-492a-97eb-ed2d056f91e9/1/badge)](https://lsamorim-test.visualstudio.com/MyFirstProject/_build/index?definitionId=1)   

[![codecov](https://codecov.io/gh/lsamorim/test/branch/master/graph/badge.svg)](https://codecov.io/gh/lsamorim/test)


---   
