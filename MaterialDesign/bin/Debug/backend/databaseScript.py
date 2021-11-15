from os import times
import sqlite3

weekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"]

targetDatabase = sqlite3.connect('progressDatabase.db')

createTableString = '''CREATE TABLE IF NOT EXISTS progress (
weekday text NOT NULL UNIQUE PRIMARY KEY, 
projectsCompleted integer NOT NULL)'''

targetDatabase.execute(createTableString)

for i in range(0,7):
    val = (weekDays[i], 0)
    targetDatabase.execute('INSERT OR IGNORE INTO progress (weekday, projectsCompleted) VALUES(?,?)', val)
    targetDatabase.commit()


selectString = "SELECT * FROM progress"
targetDatabase.commit()
result = targetDatabase.execute(selectString)
timeSpentOnProjectsY = []
for row in result:
    weekday = row[0]
    projectsCompleted = row[1]
    timeSpentOnProjectsY.append(float(projectsCompleted))
