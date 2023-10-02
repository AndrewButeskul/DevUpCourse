import { Component, OnInit } from '@angular/core';
import { UserService } from 'models/services/user.service';
import { User } from 'models/user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent implements OnInit{

  users : User[] = [];
  title = 'devup';
  
  constructor(private userService : UserService){}

  ngOnInit(): void {
    this.userService.getAll().subscribe(data => {
      this.users = data;
    })
    //this.users.push({id : 1, email: "some@email", password : "password"});
  }

  onButtonClick() : void {
    let user = new User();
    user.id = 0;
    user.email = "some@email.com"
    user.password = "new pass"
    this.userService.add(user).subscribe(data => {
      console.log("User has saved!");
    });

  }
}
