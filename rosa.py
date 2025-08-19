import turtle
import math

# Configuración de la ventana
screen = turtle.Screen()
screen.bgcolor("black")
screen.title("Rosa con Python Turtle")

# Configuración de la "pluma"
pen = turtle.Turtle()
pen.speed(0)
pen.color("red")
pen.width(2)

# Dibujar pétalos con ecuación polar de la rosa r = cos(kθ)
k = 7   # controla número de pétalos
size = 200

pen.penup()
for angle in range(0, 360*5):  # varias vueltas para rellenar
    theta = math.radians(angle)
    r = size * math.cos(k * theta)  
    x = r * math.cos(theta)
    y = r * math.sin(theta)
    if angle == 0:
        pen.goto(x, y)
        pen.pendown()
    else:
        pen.goto(x, y)

# Cambiar a color verde para el tallo
pen.penup()
pen.goto(0, -50)
pen.pendown()
pen.color("green")
pen.setheading(-90)
pen.forward(300)

# Dibujar hojas
pen.begin_fill()
pen.circle(60, 60)
pen.left(120)
pen.circle(60, 60)
pen.end_fill()

pen.hideturtle()
screen.mainloop()
