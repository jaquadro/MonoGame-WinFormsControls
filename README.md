MonoGame-WinForms
=================

This project contains a library with basic controls for embedding MonoGame content in WinForms.  The library can be used as-is, or it can be integrated directly into your codebase for further customization.

The control code is originally derived from the MSDN tutorial [WinForms Series 1: Graphics Device][1].

This code also supports a series of tutorials on embedding MonoGame in WinForms:
* [Bringing your XNA WinForms Controls to MonoGame + OpenGL][2]
* [Embedding Your MonoGame Game in a WinForms Control][3]
* [MonoGame + WinForms: Where’s My Keyboard?][4]

The intent is for this repository to unify the tutorials into a single solution that can be used as a template for actual projects.

Project Structure
-----------------

* Control Example
    * ExampleControl -- A sample control tracking mouse events to draw squares.  Updates as needed as opposed to running an update loop.
* Game Example
    * ExampleGame.Common -- A sample game engine, representing the majority of game implementation.
    * ExampleGame.Embedded -- A WinForms project.  Runs the shared game code from an embedded GameControl class.  Also include extra WinForms interactions.
    * ExampleGame -- A standard MonoGame project.  Runs the shared game code from a normal Game class.
* MonoGameWinForms -- A basic library containing GraphicsDeviceControl and GameControl base controls.

[1]: http://xbox.create.msdn.com/en-US/education/catalog/sample/winforms_series_1
[2]: http://jaquadro.com/2013/03/bringing-your-xna-winforms-controls-to-monogame-opengl
[3]: http://jaquadro.com/2013/03/embedding-your-monogame-game-in-a-winforms-control
[4]: http://jaquadro.com/2013/04/monogame-winforms-wheres-my-keyboard