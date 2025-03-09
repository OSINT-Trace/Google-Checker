AsyncHttpClient client = new DefaultAsyncHttpClient();
client.prepare("POST", "https://google-checker2.p.rapidapi.com/check_bulk")
	.setHeader("x-rapidapi-key", "Sign Up for Key")
	.setHeader("x-rapidapi-host", "google-checker2.p.rapidapi.com")
	.setHeader("Content-Type", "application/json")
	.setBody("{"input":["test@gmail.com","john@doe.com"]}")
	.execute()
	.toCompletableFuture()
	.thenAccept(System.out::println)
	.join();

client.close();