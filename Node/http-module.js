var http = require('http');
var fs = require('fs');

function benimFonksiyonum(request,response){
	if(request.url=='/'){
		
	console.log(request);
	response.writeHeader(200,{'Content-Type':'text/plain'});
	response.write('fatih çelen');
	response.end();
	}
	else{
		response.writeHeader(404,{'Content-Type':'text/plain'});
		response.write('Not Found');
		response.end();
	}
}

http.createServer(benimFonksiyonum).listen(8000);
console.log('sunucu çalişiyor');