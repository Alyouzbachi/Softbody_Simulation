# Softbody_Simulation
Pressure Model of Soft Body Simulation

## About ##
Implementing Maciej Matyka Paper # Pressure Model of Soft Body Simulation # [here] (https://arxiv.org/ftp/physics/papers/0407/0407003.pdf)
using C++ to build the body.
The soft body exposed to many forces : 

## Forces ##
internal forces :
newton laws F=ma ,
Hook's law Derivation  𝐹⃗12=  F(spring-force) + F(damping) =   (- Ks) + (- Kd).

Outer forces :
Gravity,
Pressure force,
Gauss theorem for calculating volume,
Euler 1st order integrator-second Newton's law for movement.

## Execution ##
Every force will affect the response of the soft model,Collision detection is a most to test the response of the soft model.
When executing starts first we create the object --> Accumlate forces --> Gravity --> Spring --> Pressure --> Integrate Momentum --> Visualization.

This simulation was developed in 2013 using C++ OpenGl and C# to control the variables for testing.
