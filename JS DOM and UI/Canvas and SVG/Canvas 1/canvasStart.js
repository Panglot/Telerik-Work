window.onload = function () {

    var canvas = document.getElementById('canvas');
    var ctx = canvas.getContext("2d");
    canvas.width = 1000;
    canvas.height = 850;
    canvas.style.border = "1px solid black";

    ctx.fillStyle = "#923"; // Color of the fill when you fill
    ctx.fillRect(20, 20, 40, 40);

    ctx.fillStyle = "#083";
    ctx.fillRect(120, 120, 40, 40);

    ctx.strokeStyle = "#299"; // Color of the border
    ctx.lineWidth = 5; // Border width
    ctx.strokeRect(10, 10, 300, 300); // Stroke draws only the border of things

    ctx.beginPath();//Starts a new figure
    ctx.moveTo(350, 100); // Start coordinates of figure
    ctx.lineTo(500, 50); // A line from the start to these coordinates. The line wont draw untill stroke() method is used.
    ctx.lineTo(500, 150); // Another line starting form the end of the previous
    ctx.lineTo(600, 100);
    ctx.closePath(); // Closes the figure (draws a line from the end of the last one to the start of the first one.
    ctx.lineWidth = 3;
    ctx.strokeStyle = "#222";
    ctx.stroke(); // Draws the figure defined by the above operations

    ctx.beginPath(); // Needs to be used, because the new lines will start fromt he end of the last one otherwise.
    ctx.moveTo(350, 200);
    ctx.lineTo(500, 150);
    ctx.lineTo(500, 250);
    ctx.lineTo(600, 200);
    ctx.closePath();
    ctx.lineWidth = 0;
    ctx.fillStyle = "#597";
    ctx.fill(); // Fills the figure from the inside. Even if the path isnt closed, it clsoes it and fills it.


    ctx.beginPath();
    ctx.lineWidth = 5;
    // Draws a circle. Arguments 1 and 2 are the center coordinates.
    // 3 is the radius. 4 and 5 work in radians. Basically Math.PI is
    // 180 degrees. 4 is the start of the arc, 5 is where it ends.
    // It always starts at X  = 0;
    // In this case Math.PI/2 means it will start 90 degrees off from
    // X = 0 and Math.PI will end in 180 degrees from X = 0;
    // Argument 6 is if it should draw clockwise or counterclockwise.
    // The catch is that the start will move 90 degrees from X  always clockwise
    // the end is also like this. Only the drawing will be counterclockwise.
    // This means that in this case the arc will be completely different depending
    // On the drawing direction. The default is false.
    ctx.arc(750, 100, 100, Math.PI/2, Math.PI, false);
    ctx.stroke();
    ctx.fill(); // Even Though its a circle it always closes it with straight line

    ctx.beginPath();
    // Much more adequate way is to use this formula
    // degrees * PI / 180. In this case 138*Math.PI/180 moves the end
    // To the 138th degree and then it draws from 0 to 138th clockwise.
    ctx.arc(800,70, 100, 0, 138*Math.PI/180);
    ctx.stroke();

    ctx.beginPath();
    // Simple pacman. 50 offset from start and end. Overall 100 degrees open.
    ctx.arc(90, 420, 80, 50*Math.PI/180, 310*Math.PI/180);
    // Draw a line to the center.
    ctx.lineTo(90,420);
    ctx.closePath(); // Close with line from the center to the end.
    ctx.fillStyle = "yellow";
    ctx.lineWidth = 3;
    ctx.fill(); // First fill then stroke makes better border. OTherwise it draws
    // the fill on top of the border and things clip bad.
    ctx.stroke();


    ctx.beginPath();
    ctx.lineWidth = 3;
    ctx.moveTo(50, 700);
    ctx.quadraticCurveTo(50, 800, 150, 850);
    ctx.stroke();

    //
    // if (ctx.setLineDash !== undefined) {
    //     ctx.setLineDash([5, 10]);
    // }
    //
    // if (ctx.mozDash !== undefined) {
    //     ctx.mozDash = [5, 10];
    // }
    //
    // ctx.beginPath();
    // ctx.moveTo(17, 1);
    // ctx.lineTo(150, 400);
    // ctx.lineTo(470, 0);
    //
    // ctx.moveTo(100, 250);
    // ctx.lineTo(250, 275);
    // ctx.stroke();


    ctx.beginPath();
    ctx.lineWidth = 3;
    ctx.moveTo(190, 430);
    // Much math. Many calculations. I dont like. It has lines and tangents
    // of these lines and it draws the curves according to the tangents.
    ctx.bezierCurveTo(290, 300, 300, 400, 400, 400);
    ctx.bezierCurveTo(400, 300, 388, 270, 750, 350);
    ctx.stroke();


    // Argument 1 source. Argument 2 - 5 are for cropping.
    // 2, 3 are x and y of the crop. 4 - 5 are widh and height
    // of the crop. 6 - 9 are the image draw. 6, 7 are x and y
    // of canvas to draw on. 8, 9 are width and height of the image.
    //ctx.drawImage(img,90,135,60,60,10,10,220,277);
}