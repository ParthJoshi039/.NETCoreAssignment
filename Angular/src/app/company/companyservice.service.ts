import { Company } from './companyservice.model';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, throwError } from 'rxjs';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { catchError } from 'rxjs/operators';
import {Companies} from './companies'

@Injectable({
  providedIn: 'root'
})
export class CompanyserviceService {

  constructor(private httpClient:HttpClient) { }
  
  private apiServer = "http://localhost:3000";
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

  create(company:any): Observable<Companies> {
    return this.httpClient.post<Companies>(this.apiServer + '/Company', JSON.stringify(company), this.httpOptions)
    .pipe(
      catchError(this.errorHandler)
    )
  } 

  getById(id:number): Observable<Companies> {
    return this.httpClient.get<Companies>(this.apiServer + '/Company/' + id)
    .pipe(
      catchError(this.errorHandler)
    )
  }

  getAll(): Observable<Companies[]> {
    return this.httpClient.get<Companies[]>(this.apiServer + '/Company')
    .pipe(
      catchError(this.errorHandler)
    )
  }

  
  update(id:number, company:any): Observable<Companies> {
    return this.httpClient.put<Companies>(this.apiServer + '/Company/' + id, JSON.stringify(company), this.httpOptions)
    .pipe(
      catchError(this.errorHandler)
    )
  }

  delete(id:number){
    return this.httpClient.delete<Companies>(this.apiServer + '/Company/' + id, this.httpOptions)
    .pipe(
      catchError(this.errorHandler)
    )
  }

  errorHandler(error: any){
    let errorMessage = '';
    if(error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }
  
}
