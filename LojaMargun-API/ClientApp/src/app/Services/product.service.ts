import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../Models/Product';

const option = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  }) 
}

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  url: string = "api/Product";

  constructor(private http: HttpClient) { }

  AddProduct(product: Product): Observable<any> {
    return this.http.post<any>(this.url, product, option);
  }

  UpdateProduct(product: Product): Observable<any> {
    return this.http.put<any>(this.url, product, option);
  }

  RemoveProduct(productId: number): Observable<any> {
    const url = `${this.url}/${productId}`;
    return this.http.delete(url, option);
  }

  GetById(id: number): Observable<Product> {
    const url = `${this.url}/${id}`;
    return this.http.get<Product>(url);
  }

  GetAllProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.url);
  }
}
