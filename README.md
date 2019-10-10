# SOLID-principles
> Examples of SOLID principles compared to bad design


SOLID Principles is an acronym of five principles.
1. **S** - Single Responsibility Principle
2. **O** - Open/Closed Principle
3. **L** - Liskov’s Substitution Principle
4. **I** - Interface Segregation Principle
5. **D** -Dependency Inversion Principle


# SRP = [Single responsibility principle](https://github.com/LSIND/SOLID-principles/tree/master/SolidExamples/SolidExamplesApp/SRP)
> Every class should have responsibility over a single part of the functionality and that responsibility should be entirely encapsulated by this class.

Example.
Class *Car* has the following information:
- Model name, year of issue which should be from 2010 to 2019
- You can print details about a car object

| bad design             |  good design |
-------------------------|-------------------------
Car class contains properties <br/> and a method | A car itself cannot print. Create another class *Printer* <br/> with a method which takes *Car* object as a parameter
![SRP bad design](https://www.dropbox.com/s/mnufnytwr571g58/SRP_BadDesign.JPG?raw=1)  |  ![SRP good design](https://www.dropbox.com/s/h758dwso18azkwo/SRP_GoodDesign.JPG?raw=1)


# LSP = [Liskov’s Substitution Principle](https://github.com/LSIND/SOLID-principles/tree/master/SolidExamples/SolidExamplesApp/LSP)
> Derived classes should extend base classes not change it.

Example:
Base class *Vehicle* contains two methods of calculating a rent of vehicle and getting information about it. Classes *Bus* and *Car* inherit from *Vehicle* but there is no ability to rent a *Bus*.

| bad design             |  good design |
-------------------------|-------------------------
Trying to instantiate a list of *Vehicle* type and add both <br/> *Car and *Bus* objects to it will lead to error | Create two interfaces instead of class *Vehicle* <br/> and let *Car* implement both and *Bus* - only *IVehicle*
![LSP bad design](https://www.dropbox.com/s/kfvveysfszcxl30/LSP_BadDesign.PNG?raw=1)  |  ![LSP good design](https://www.dropbox.com/s/76sxwcswfd0d6w5/LSP_GoodDesign.PNG?raw=1)


# ISP = [Interface Seggregation Principle](https://github.com/LSIND/SOLID-principles/tree/master/SolidExamples/SolidExamplesApp/ISP)
> Classes should not depend on methods they do not use.

Example.
Two classes with similar functionaly *Bus* and *Car*:
 - You can print details about a vehicle
 - You can add new car but not a new bus. 

| bad design             |  good design |
-------------------------|-------------------------
*Car* and *Bus* classes implement *IVehicle* <br/> interface  with two methods | You cannot add a new bus, so *Bus* class should not implement <br/> *IVehicle* interface. In this case divide *IVehicle* interface<br/> into two interfaces with different methods
![ISP bad design](https://www.dropbox.com/s/k2zexaqw7lcgjys/ISP_BadDesign.JPG?raw=1) |  ![ISP good design](https://www.dropbox.com/s/i2xjstwmg45ohly/ISP_GoodDesign.JPG?raw=1)

