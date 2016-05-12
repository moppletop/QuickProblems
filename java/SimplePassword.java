package io.github.moppletop.quickproblems;

import java.util.Scanner;

public class SimplePassword {

	public static void password() {
		System.out.println("What the password?");

		Scanner scanner = new Scanner(System.in);
		String password = scanner.nextLine();

		if (password.equals("myPassword")) {
			System.out.println("The password is correct");
		} else {
			System.out.println("The password is incorrect");
		}
		scanner.close();
	}
}
