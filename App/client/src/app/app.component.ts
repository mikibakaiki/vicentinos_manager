import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
    title = 'The Vicentinos Manager';
    users: any;

    constructor(private http: HttpClient) { }

    ngOnInit(): void {
        this.getUsers();
    }

    getUsers() {
        this.http.get('https://localhost:5001/api/users').subscribe(u => {
            this.users = u;
        }, error => {
            console.log("Error => ", error);
        });
    }
}
