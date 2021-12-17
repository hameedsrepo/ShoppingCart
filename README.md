# ShoppingCart
Shopping Cart Assessment for Equal Experts by Hameed Ebadi

# Goal
Create a shopping cart via TDD/BDD (no UI) that keeps track of the total price of goods added to the cart and calculate taxes.

# Weird Bug
I encountered a weird bug where the modulo operator (%) doesn't work quite correctly.  When you take the modulo of anything by 1 you expect the decimal places but for some reason when you encounter 0.995 it isn't represented accurately.  Even when you use a decimal value for more precision.  This consequently causes unit test "CacluateTax" to fail (AC3).

String.Format("F") should have also been a solution but that doesn't work either.  Perhaps it is my version of VS or the framework I'm using? It works fine when I use www.dotnetfiddle.com as an online compiler to debug.

# Additional Notes
Adding more unit tests would be a good idea but I'm curious to know if the bug I encountered truly is a bug or a known issue that was strategically chosen so I could write a workaround.
