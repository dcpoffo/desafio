/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { JogoReadComponent } from './jogo-read.component';

describe('JogoReadComponent', () => {
  let component: JogoReadComponent;
  let fixture: ComponentFixture<JogoReadComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JogoReadComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JogoReadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
