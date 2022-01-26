import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../Models/Product';

const httpOption = {
  headers: new HttpHeaders({
    'Content-Type':'application/json'
  })
}
@Injectable({
  providedIn: 'root'
})
export class ProductService {
  url = 'API/Product';
  constructor(private http: HttpClient) { }

  Add(product : Product): Observable<any>{
    return this.http.post<any>(this.url, product, httpOption);
  }

  Update(product: Product): Observable<any>{
    return this.http.put<any>(this.url, product, httpOption);
  }

  Remove(productId : number): Observable<any>{
    const url = `${this.url}/${productId}`;
    return this.http.delete(url);
  }

  GetAll(): Observable<Product[]>{
    return this.http.get<Product[]>(this.url);
  }

  GetById(productId: number): Observable<Product>{
    const url = `${this.url}/${productId}`
    return this.http.get<Product>(url);
  }
}
