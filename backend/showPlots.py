from os import times
from matplotlib import lines
import matplotlib.pyplot as plt
import numpy as np


def setup():
    timeSpentOnProjectsY = np.array([1,0,63,8,5,6,7])

    weekDays = np.array(["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"])

    colors = {
        'projectYellow' : '#f2d03b',
        'projectDarkestBlue' : '#003056',
        'projectLighterBlue' : '#05518b',
        'projectSkyBlue' : '#05518b',
        'projectPlanktonGreen' : '#46d9bf',
    }

    plotData(weekDays, timeSpentOnProjectsY, colors)

def plotData(weekDays, timeSpentOnProjects, colors):

    # get data from frontend if button for night mode is on or off
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