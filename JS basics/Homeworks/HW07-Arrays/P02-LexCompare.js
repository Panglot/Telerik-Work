function functionName(args) {
  var result = '=';
  var str = args[0].split('\n');
  if (str[0] == str[1]) {
    console.log('=');
  }
  else if (str[0] >str[1]) {
    console.log('>');
  }
  else {
    console.log('<');
  }
}

functionName(['hello', 'halo'])
