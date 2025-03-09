const http = require('https');

const options = {
	method: 'POST',
	hostname: 'google-checker2.p.rapidapi.com',
	port: null,
	path: '/check_bulk',
	headers: {
		'x-rapidapi-key': 'Sign Up for Key',
		'x-rapidapi-host': 'google-checker2.p.rapidapi.com',
		'Content-Type': 'application/json'
	}
};

const req = http.request(options, function (res) {
	const chunks = [];

	res.on('data', function (chunk) {
		chunks.push(chunk);
	});

	res.on('end', function () {
		const body = Buffer.concat(chunks);
		console.log(body.toString());
	});
});

req.write(JSON.stringify({
  input: [
    'test@gmail.com',
    'john@doe.com'
  ]
}));
req.end();