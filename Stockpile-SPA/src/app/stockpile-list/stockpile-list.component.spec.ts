/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { StockpileListComponent } from './stockpile-list.component';

describe('StockpileListComponent', () => {
  let component: StockpileListComponent;
  let fixture: ComponentFixture<StockpileListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StockpileListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StockpileListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
