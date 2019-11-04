import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment.prod';

@Injectable()
export class LoginService {
  private baseapi = environment.apiUrl;
 
  constructor(private http: HttpClient) { }

  userLogin(data) { 
    
      return this.http.post(this.baseapi + "/api/account/login", JSON.stringify(data) ,{ headers: this.GetHttpHeaders() });
  }

  GetHttpHeaders() : HttpHeaders{
    const headers = new HttpHeaders().set('content-type', 'application/json');
    return headers;
  }
}
