import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../shared/user.service';
//import { UserService } from '../shared/user.service';

@Component({
  selector: 'app-users-ui',
  templateUrl: './users-ui.component.html',
  styleUrls: ['./users-ui.component.css']
})
export class UsersUiComponent implements OnInit {
  userDetails;
  token;

  constructor(private router: Router, private service: UserService) { }

  ngOnInit() {

    this.service.getUserProfile().subscribe(
      res => {
        this.userDetails = res;
        var token = localStorage.getItem('token');
        this.token = token;
      },
      err => {
        console.log(err);
      },
    );
  }


  Logout() {
    localStorage.removeItem('token');
    this.router.navigate(['/home']);
  }
}
