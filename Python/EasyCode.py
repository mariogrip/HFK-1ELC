#setter opp
Import RPi.GPIO as g
g.setmode(g.BOARD)
g.setup(7, g.OUT)

# Slå på Output
g.output(7, False)

# Slå av Output
g.output(7, True)
