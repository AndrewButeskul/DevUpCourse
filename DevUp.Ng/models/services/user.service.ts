import {HttpClient} from "@angular/common/http";
import { createInjectableType } from "@angular/compiler";
import { Injectable } from "@angular/core";
import { User } from "models/user";
import { Observable } from "rxjs";

@Injectable({providedIn : "root"})
export class UserService {
    
    constructor(private client : HttpClient){}

    getAll() : Observable<User[]>
    {
        return this.client.get<User[]>("/api/user");
    }

    add(user : User) : Observable<any> {
        return this.client.post("/api/user", user);
    }
}