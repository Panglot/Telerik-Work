function solve(args) {
    var str = JSON.parse(args[0]);
    var result = args[1];

    for (var property in str) {
        var regex = new RegExp("#\{"+property+"\}", "g");result = result.replace(regex, str[property]);
    }
    console.log(result);
}

solve([
    '{ "name": "John" }',
    "Hello, there! Are you #{name}?"
])