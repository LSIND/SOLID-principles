# SOLID-principles
Examples of SOLID principles compared to bad design

# SRP = [Single responsibility principle](https://github.com/LSIND/SOLID-principles/tree/master/SolidExamples/SolidExamplesApp/SRP)
Every class should have responsibility over a single part of the functionality and that responsibility should be entirely encapsulated by this class.

Example.
Class *Car* has the following information:
- Model name, year of issue which should be from 2010 to 2019
- You can print details about a car object

Bad design

![SRP bad design](https://www.dropbox.com/s/mnufnytwr571g58/SRP_BadDesign.JPG?raw=1)

Good design

A car itself cannot print. Create another class *Printer* with a method which takes *Car* object as a parameter.

![SRP good design](https://www.dropbox.com/s/h758dwso18azkwo/SRP_GoodDesign.JPG?raw=1)

# ISP = Interface Seggregation Principle
Classes should not depend on methods they do not use.

Example.
Two classes with similar functionaly *Bus* and *Car*:
 - You can print details about a vehicle
 - You can add new car but not a new bus. 

Bad design

![ISP bad design](https://www.dropbox.com/s/k2zexaqw7lcgjys/ISP_BadDesign.JPG?raw=1)

Good design

You cannot add a new bus, so *Bus* class should not implement *IVehicle* interface. In this case divide IVehicle interface into two interfaces with different methods.

![ISP good design](https://www.dropbox.com/s/i2xjstwmg45ohly/ISP_GoodDesign.JPG?raw=1)

