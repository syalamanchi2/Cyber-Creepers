import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
    providedIn:'root'
})
export class CreeperService {

 constructor(private http:HttpClient){}

getLOBs(){
    return this.http.get('http://localhost:8080/creeperservice/lobs');
 }
getDeals()
{
    return this.http.get('http://localhost:8080/creeperservice/lobs');
}

}