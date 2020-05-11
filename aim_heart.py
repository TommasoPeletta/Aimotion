import numpy as np
import sys
import time
import cv2
import re
import threading
import GUI
import zmq
from process import Process
from webcam import Webcam
from PyQt5 import QtCore
from PyQt5.QtWidgets import *
from PyQt5.QtGui import *
from PyQt5.QtCore import *



bpm = "0.0"
continuer = True
v = 0


class runGUI(threading.Thread):

    def __init__(self):
        threading.Thread.__init__(self)

    def run(self):
        global v
        app = QApplication(sys.argv)
        v = GUI.GUI()
        input = Webcam()
        v.run(input)



class heartRate(threading.Thread):

    def __init__(self):
        threading.Thread.__init__(self)

    def run(self):
        global v
        global bpm
        bpm = float(re.findall("\d+\.\d+", v.lblHR2.text())[0])



t1 = runGUI()
t1.start()
context = zmq.Context()
socket = context.socket(zmq.REP)
# socket.bind("tcp://*:5555")
socket.bind("tcp://*:4443")
while continuer:
    socket.recv()
    t2 = heartRate()
    t2.start()
    socket.send_string(str(bpm))
    t2.join()
    # threading.activeCount() if you want to see the number of thread runnning
