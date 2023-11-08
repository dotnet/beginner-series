$CSV_FILE = "train.csv"
if (!(Test-Path "..\Data\$CSV_FILE")) {
    Invoke-WebRequest -Uri "https://raw.githubusercontent.com/PolyAI-LDN/task-specific-datasets/master/banking_data/$CSV_FILE" -OutFile "..\Data\$CSV_FILE"
    Write-Host "File downloaded"
}
Write-Host "Skipping file download"

$ZIP_FILE = "assets.zip"
if (!(Test-Path "..\Data\$ZIP_FILE")) {
    Invoke-WebRequest -Uri "https://github.com/dotnet/machinelearning-samples/raw/main/samples/csharp/getting-started/DeepLearning_ImageClassification_Binary/DeepLearning_ImageClassification/$ZIP_FILE" -OutFile "..\Data\$ZIP_FILE"
    Write-Host "File downloaded"
    Expand-Archive -Path "..\Data\$ZIP_FILE" -DestinationPath "..\Data"
    Write-Host "File unzipped"
}