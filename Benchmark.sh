#!/bin/bash

cd "$(dirname "$0")" || exit 1

rm -rf BenchmarkDotNet.Artifacts
dotnet clean source/Ecs.CSharp.Benchmark/Ecs.CSharp.Benchmark.csproj -c Release

dotnet build source/Ecs.CSharp.Benchmark/Ecs.CSharp.Benchmark.csproj -c Release /p:CheckCacheMisses=true
if [ $? -ne 0 ]; then
    exit 1
fi

dotnet run --project source/Ecs.CSharp.Benchmark/Ecs.CSharp.Benchmark.csproj -c Release --no-build --anyCategories DefaultEcs
