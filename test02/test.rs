use std::io;
fn main() {
    println!("Hello World");
    let mut line = String::new();
    io::stdin().read_line(&mut line);
}

