#!/bin/bash
CSV_FILE=issues_train.tsv
if [ ! -f "../Data/$CSV_FILE" ]; then
    wget -P ../Data https://raw.githubusercontent.com/PolyAI-LDN/task-specific-datasets/master/banking_data/$CSV_FILE
    echo "File downloaded"
fi
echo "Skipping file download"

ZIP_FILE=assets.zip
if [ ! -f "../Data/$ZIP_FILE" ]; then
    wget -P ../Data https://github.com/dotnet/machinelearning-samples/raw/main/samples/csharp/getting-started/DeepLearning_ImageClassification_Binary/DeepLearning_ImageClassification/$ZIP_FILE
    echo "File downloaded"
    unzip -d ../Data ../Data/$ZIP_FILE
    echo "File unzipped"
fi