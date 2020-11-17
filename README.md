This is a minimal repro for bug #488 of minio-dotnet (https://github.com/minio/minio-dotnet/issues/488).

Steps:
1. Run minio on docker with default settings.
2. Create an empty bucket named "bug".
3. Run code. The line that requests object list from the bucket throws an error.
