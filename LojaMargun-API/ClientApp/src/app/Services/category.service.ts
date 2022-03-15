import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../Models/Category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  url: string = "api/Category";

  constructor(private http: HttpClient) { }

  GetAlCategories(): Observable<Category[]> {
    return this.http.get<Category[]>(this.url);
  }
}
