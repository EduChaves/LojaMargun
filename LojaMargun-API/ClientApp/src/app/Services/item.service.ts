import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Item } from '../Models/Item';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})

export class ItemService {
  url = "API/Item";

  constructor(private http: HttpClient) { }

  AddProduct(data: Item): Observable<any>{
    return this.http.post<any>(this.url, data, httpOptions);
  }

  UpdateProduct(data: Item): Observable<any>{
    return this.http.put<any>(this.url, data, httpOptions);
  }

  RemoveProduct(id: number): Observable<any>{
    const url = `${this.url}/${id}`;
    return this.http.delete<any>(this.url, httpOptions);
  }

  GetProduct(id: number): Observable<Item>{
    const url = `${this.url}/${id}`;
    return this.http.get<Item>(url);
  }

  GetAllProducts(): Observable<Item[]>{
    return this.http.get<Item[]>(this.url);
  }

  SaveImage(data: FormData): Observable<any> | null{
    const url = `${this.url}/SaveImage`;
    //return this.http.post<any>(url, data, httpOptions);
    return null;
  }
}