# xUnit Parallel Example

This is a playground environment to see what impacts tests running in parallel.

- https://xunit.net/docs/running-tests-in-parallel
- https://xunit.net/docs/configuration-files

## Running

### Requires 

- .NET Core 3.0

In Visual Studio 2019, open Test Explorer and click **Run All Tests**

- Note: In the **Test Explorer** there is a setting of **Run Tests In Parallel**. Play around with this & `xunit.runner.json`

## Design

From xUnit's documentation, this is the expected behaviour:

- Tests in same TestCollection (by default, a class) will run sequentially
- Tests in different TestCollections will run in parallel
- Assemblies will not run in parallel but can be changed via configuration

## Configuration

### Unit Tests

- Run tests in parallel in same assembly
- Run tests in parallel with other assemblies

### Component Tests

- Does not run tests in parallel in same assembly
- Run tests in parallel with other assemblies

### Integration Tests

- Does not run tests in parallel in same assembly
- Does not run tests in parallel with other assemblies

## Issues

Visual Studio 2019 parallel settings appears to completely ignore `xunit.runner.json`

- Disabling running in parallel, no assembly runs in parallel
- Enabling running in parallel, all assemblies run in parallel

## Contributing & Feedback

Feel free to make an issue / PR for any mistakes I've made