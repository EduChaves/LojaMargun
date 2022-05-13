import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../Models/Product';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})

export class ProductService {
  url = "API/Product";

  constructor(private http: HttpClient) { }

  AddProduct(data: Product): Observable<any>{
    return this.http.post<any>(this.url, data, httpOptions);
  }

  UpdateProduct(data: Product): Observable<any>{
    return this.http.put<any>(this.url, data, httpOptions);
  }

  RemoveProduct(id: number): Observable<any>{
    const url = `${this.url}/${id}`;
    return this.http.delete<any>(this.url, httpOptions);
  }

  GetProduct(id: number): Observable<Product>{
    const url = `${this.url}/${id}`;
    return this.http.get<Product>(url);
  }

  GetAllProducts(): Observable<Product[]>{
    return this.http.get<Product[]>(this.url);
  }

  SaveImage(data: FormData): Observable<any> | null{
    const url = `${this.url}/SaveImage`;
    //return this.http.post<any>(url, data, httpOptions);
    return null;
  }
}