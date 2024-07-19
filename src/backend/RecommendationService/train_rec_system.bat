REM Purpose: This batch file is used to train the recommendation system. It runs the python scripts that get the ratings from de database, then train the recommendation system with those new ratings and after that runs the main.py to predict new projects and insert them on de database.

@echo off
python run_psql_train.py

cd ModelUtils

python train.py

cd ..

python main.py
