import sqlite3


targetDatabase = sqlite3.connect('progressDatabase.db')

createAllProjectsTableString = '''CREATE TABLE IF NOT EXISTS allProjects (
projectName VARCHAR(255) NOT NULL UNIQUE PRIMARY KEY, 
projectCompleted integer NOT NULL)'''

targetDatabase.execute(createAllProjectsTableString)

allProjects = "SELECT * FROM allProjects"

projectsResult = targetDatabase.execute(allProjects)

for row in projectsResult:
    print(row)