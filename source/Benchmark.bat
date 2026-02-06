@ECHO off

pushd %~dp0

DEL /q /s BenchmarkDotNet.Artifacts
dotnet clean Ecs.CSharp.Benchmark\Ecs.CSharp.Benchmark.csproj -c Release

dotnet build Ecs.CSharp.Benchmark\Ecs.CSharp.Benchmark.csproj -c Release
IF %ERRORLEVEL% GTR 0 GOTO :end

dotnet run --project Ecs.CSharp.Benchmark\Ecs.CSharp.Benchmark.csproj -c Release --no-build

:end
