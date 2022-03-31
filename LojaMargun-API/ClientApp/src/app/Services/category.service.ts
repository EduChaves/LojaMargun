import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../Models/Category';

@Injectable({
  providedIn: 'root'
})

export class CategoryService {
  url = "API/Category";

  constructor(private http: HttpClient) { }

  GetAll(): Observable<Category[]> {
    return this.http.get<Category[]>(this.url);
  }
}
