function functionName(args) {
  if (parseInt(args[0]/100)%10 == 7) {
    console.log("true");
  }
  else {
        console.log("false " + parseInt(args[0]/100)%10);
  }
}

functionName([5])
