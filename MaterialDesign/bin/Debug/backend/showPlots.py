import csv
import os
try:
    import matplotlib
    import matplotlib.pyplot as plt
    import numpy as np
except:
    os.system("pip install matplotlib")
    os.system("pip install numpy")

def setup():

    timeSpentOnProjectsY = []
    with open('./Data.csv') as dataSource:
        csv_reader = csv.reader(dataSource)
        for row in csv_reader:
            for single_element in row:
                timeSpentOnProjectsY.append(float(single_element))
                
    weekDays = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"]

    colors = {
        'projectYellow' : '#f2d03b',
        'projectDarkestBlue' : '#003056',
        'projectLighterBlue' : '#05518b',
        'projectSkyBlue' : '#05518b',
        'projectPlanktonGreen' : '#46d9bf',
    }

    plotData(weekDays, timeSpentOnProjectsY, colors)

def plotData(weekDays, timeSpentOnProjects, colors):

    darkTheme = "on"

    if darkTheme == "on":
        plt.style.use('dark_background')
        plt.bar(weekDays, timeSpentOnProjects, color=colors["projectYellow"])
    else:
        plt.style.use('ggplot')
        plt.bar(weekDays, timeSpentOnProjects,color=colors["projectPlanktonGreen"])
        plt.hsv()

    plt.title('Your Tasks Statistics')
    plt.ylabel('Amount of Completed Projects')
    plt.show()


setup()
