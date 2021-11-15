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
#updateQuery = '''UPDATE progress SET projectsCompleted = 2 WHERE weekday = #"Thursday"'''
#targetDatabase.execute(updateQuery)
targetDatabase.commit()
result = targetDatabase.execute(selectString)

for row in result:
    print(row)
