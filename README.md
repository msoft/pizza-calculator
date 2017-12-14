# pizza-calculator
Simple example of hexagonal architecture.

The purpose is to calculate the number of required pizzas for feeding a given number of persons. 

We consider that:
- Everybody eats the same type of pizza and 
- A pizza is composed of 6 slices

The input parameters are:
- The number of persons to feed
- The type of pizza

The domain within the hexagon calculates the number of required pizzas using the given input parameters. The hexagon uses a repository containing the average number of slices required for feeding one person depending of the type of pizza. 

The project objects are:
- [PizzaCalculator](src/PizzaCalculator.cs): the domain/the hexagon
- [IPizzaCalculator](src/IPizzaCalculator.cs): primary port defining the interface of the hexagon.
- [IPizzaRepository](src/IPizzaRepository.cs): secondary port defining the external objects called by the hexagon. 
- [ConsoleAdapter](src/ConsoleAdapter.cs): primary adapter reading the input parameters and calling the hexagon.
- [RepositoryAdapter](src/RepositoryAdapter.cs): secondary adapter satisfying IPizzaRepository. This adapter is called by the hexagon. 
