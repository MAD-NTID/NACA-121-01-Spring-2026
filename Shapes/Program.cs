// Second Demo Using Rectangle Class
IShape[] rectangles = new IShape[2];
rectangles[0] = new Rectangle(5, 10);

// this should throw an exception, it's not a rectangle
// rectangles[1] = new Rectangle(2, 2);
rectangles[1] = new Rectangle(2, 3);

foreach(IShape shape in rectangles)
{
    Console.WriteLine($"{shape.Draw()} with Length {shape.Length} and Width {shape.Width}");
    Console.WriteLine($"Area: {shape.Area()}");
    Console.WriteLine($"Perimeter: {shape.Perimeter()}");
    Console.WriteLine();
}

// First Demo Using Shape Class - 
// // Arrays are fixed length it can't grow or shrink in size
// IShape[] shapes = new IShape[1000];

// shapes[0] = new Shape("Circle");
// shapes[1] = new Shape("Square");
// shapes[2] = new Shape("Rectangle");

// // for(int i = 0; i < shapes.Length; i++)
// //     Console.WriteLine(shapes[i].Draw());

// foreach(IShape shape in shapes)
// {
//     // Since the array has 1000 items (null ones)
//     // Print only those that are not nutll
//     if(shape != null)
//         Console.WriteLine(shape.Draw());
// }
