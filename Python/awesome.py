import RPi.GPIO as g
from time import sleep
g.setmode(g.BOARD)
g.setup(7, g.OUT)
g.setup(11, g.IN)

while 1:
    if g.input(11):
        g.output(7, False)
        sleep(3)
        g.output(7, True)
