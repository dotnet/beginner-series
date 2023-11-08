#!/bin/bash

mlnet text-classification --dataset .\Data\issues_train.tsv --has-header true --label-col "Area" --text-col "Title" --split-ratio 0.2 --device "cuda:0"