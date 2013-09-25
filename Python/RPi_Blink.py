#setter opp
Import RPi.GPIO as g
from time import sleep
g.setmode(g.BOARD)
g.setup(7, g.OUT)


while 1:
    g.output(7, False)
    sleep(1); 
    g.output(7, True)
