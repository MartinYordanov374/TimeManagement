from os import times
import sqlite3

weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"]

targetDatabase = sqlite3.connect('progressDatabase.db')
timeSpentOnProjectsY = []

def createTables():
    # creating the progress and allProjects tables
    createTableString = '''CREATE TABLE IF NOT EXISTS progress (
    weekday VARCHAR(255) NOT NULL UNIQUE PRIMARY KEY, 
    projectsCompleted integer NOT NULL)'''


    targetDatabase.execute(createTableString)

    createAllProjectsTableString = '''CREATE TABLE IF NOT EXISTS allProjects (
    projectName VARCHAR(255) NOT NULL PRIMARY KEY)'''

    targetDatabase.execute(createAllProjectsTableString)


    createProjectsDueTableString = '''CREATE TABLE IF NOT EXISTS projectsDue (
    projectsDue integer NOT NULL )'''

    targetDatabase.execute(createProjectsDueTableString)





    

def populateTables():
    for i in range(0,7):
        val = (weekDays[i], 0)
        targetDatabase.execute('INSERT OR IGNORE INTO progress (weekday, projectsCompleted) VALUES(?,?)', val)
        targetDatabase.commit()

    selectString = "SELECT * FROM progress"
    targetDatabase.commit()
    result = targetDatabase.execute(selectString)

    for row in result:
        weekday = row[0]
        projectsCompleted = row[1]
        timeSpentOnProjectsY.append(float(projectsCompleted))
        
    testQuery = "SELECT * FROM allProjects"
    testResult = targetDatabase.execute(testQuery)
    for row in testResult:
        print(row)

createTables()

populateTables()
